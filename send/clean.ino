

int IRledPin =  7;
unsigned int displayInt;

void setup(){                
  pinMode(IRledPin, OUTPUT);
  Serial.begin(9600);
}

//RAW buttons data
const int cold23[] = {9600, 4800, 600, 1800, 600, 1800, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 1800, 600, 600, 600, 1800, 600, 1800, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 1800, 600, 1800, 600, 1800, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 1800, 600, 1800, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 8400, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 600, 1800, 600, 1800, 600, 1800, 600, 600, 600, 600, 600, 600, 600, 1800, 600, 1800, 600};
const int cold23_len =  sizeof(cold23) / sizeof(cold23[0]);

void loop()                
{
  send_data(cold23, cold23_len);
delay(1000);
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

   for (int k = 0; k < size; k=k+2)
  {
    pulse(IRsignal[k]);
    delayMicroseconds(IRsignal[k+1]);
  };
 }
