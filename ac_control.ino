#include <avr/pgmspace.h>
#include <Adafruit_Sensor.h>
#include <DHT.h>
#include <DHT_U.h>
DHT_Unified dht(2, DHT22);


int IRledPin =  7;
unsigned int displayInt;

//String flag =  "wait_up_edge";
//String flag =  "wait_low_edge";

String flag =  "wait_low_edge";

void setup(){                
  pinMode(IRledPin, OUTPUT);
  dht.begin();
  sensor_t sensor;
  Serial.begin(9600);
}

//RAW buttons data
const  int on_off[] PROGMEM = {9440, 4640,640, 1700,660, 1700,640, 540,640, 560,640, 540,640, 540,640, 540,640, 1720,640, 540,640, 1720,640, 1700,640, 560,640, 540,640, 540,640, 540,640, 560,640, 1700,640, 1720,640, 1700,640, 560,640, 540,640, 540,640, 540,640, 560,640, 540,640, 1700,640, 540,660, 540,640, 1700,660, 540,640, 540,640, 560,640, 520,660, 520,660, 540,640, 540,640, 560,640, 540,640, 540,640, 540,640, 540,660, 540,640, 540,640, 540,640, 560,620, 560,640, 540,640, 540,640, 8300,640, 540,640, 540,640, 540,660, 520,660, 540,640, 540,640, 540,660, 520,660, 540,640, 540,640, 540,640, 540,660, 520,660, 540,640, 540,640, 540,640, 560,640, 540,640, 540,640, 540,660, 540,640, 540,640, 540,640, 540,640, 540,660, 540,640, 540,640, 540,640, 540,660, 540,640, 540,640, 540,640, 560,640, 540,640, 540,640, 540,640, 540,660, 540,640, 540,640, 540,640, 540,640, 560,640, 540,640, 540,640, 540,660, 540,640, 540,640, 540,640, 540,640, 540,660, 540,640, 540,640, 540,640, 540,660, 520,660, 600,640, 1700,640, 560,620, 1720,640, 540,660, 1700,640, 540,640, 540,640, 560,640};




void loop()                
{ 
   delay(2000);
  sensors_event_t event;
  dht.temperature().getEvent(&event);
  if (isnan(event.temperature)==false) {
    Serial.print(F("t"));
    Serial.print(event.temperature);
    Serial.print(" ");
    Serial.println(flag);
    
    if (event.temperature < 20 )
      {
         if (flag ==  "wait_low_edge")
         {
           Serial.println("flag is  wait_low_edge");
          send_data(on_off, sizeof(on_off) / sizeof(on_off[0]));
          flag = "wait_up_edge";
             Serial.println("flag set wait_up_edge");
          }
        }

    if (event.temperature > 23 )
      {
         if (flag ==  "wait_up_edge")
         {
             Serial.println("flag is  wait_up_edge");
          send_data(on_off, sizeof(on_off) / sizeof(on_off[0]));
          flag = "wait_low_edge";
           Serial.println("flag set wait_low_edge");
          }
        }


  }




    


}
 
void pulse(long microsecs) {
  cli();
  while (microsecs > 0) 
  { // 38 kHz is about 13 microseconds high and 13 microseconds low
   digitalWrite(IRledPin, HIGH);  // this takes about 3 microseconds to happen
   delayMicroseconds(10);         // hang out for 10 microseconds, you can also change this to 9 if its not working
   digitalWrite(IRledPin, LOW);   // this also takes about 3 microseconds
   delayMicroseconds(10);         // hang out for 10 microseconds, you can also change this to 9 if its not working
   microsecs -= 26;   // so 26 microseconds altogether
  } sei();
}

//send data by IR
void send_data(int IRsignal[], int size){
  Serial.println("Sending IR signal");

   for (int k = 0; k < size; k=k+2)
  {
    pulse(pgm_read_word_near(IRsignal + k));
    delayMicroseconds(pgm_read_word_near(IRsignal + k+1));
  };
 }
