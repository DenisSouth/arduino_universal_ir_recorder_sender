#define IRpin_PIN      PIND
#define IRpin          2

#define MAXPULSE 65000

#define RESOLUTION 20 

uint16_t pulses[400][2];  // pair is high and low pulse
uint16_t currentpulse = 0; // index for pulses we're storing

void setup(void) {
  Serial.begin(9600);
  Serial.println("Ready to decode IR!");
}

void loop(void) {
  uint16_t highpulse, lowpulse;  // temporary storage timing
  highpulse = lowpulse = 0; // start out with no pulse length
  
  
//  while (digitalRead(IRpin)) { // this is too slow!
    while (IRpin_PIN & (1 << IRpin)) {
     // pin is still HIGH

     // count off another few microseconds
     highpulse++;
     delayMicroseconds(RESOLUTION);

     // If the pulse is too long, we 'timed out' - either nothing
     // was received or the code is finished, so print what
     // we've grabbed so far, and then reset
     if ((highpulse >= MAXPULSE) && (currentpulse != 0)) {
       printpulses();
       currentpulse=0;
       return;
     }
  }
  // we didn't time out so lets stash the reading
  pulses[currentpulse][0] = highpulse;
  
  // same as above
  while (! (IRpin_PIN & _BV(IRpin))) {
     // pin is still LOW
     lowpulse++;
     delayMicroseconds(RESOLUTION);
     if ((lowpulse >= MAXPULSE)  && (currentpulse != 0)) {
       printpulses();
       currentpulse=0;
       return;
     }
  }
  pulses[currentpulse][1] = lowpulse;
  // we read one high-low pulse successfully, continue!
  currentpulse++;
}

void printpulses(void) {
  // print it in a 'array' format
  Serial.print(F("const int Button[] PROGMEM = {"));
  //Serial.println(F("// ON, OFF (in 10's of microseconds)"));
  for (uint8_t i = 0; i < currentpulse-1; i++) {
   // Serial.print(F("\t")); // tab
    Serial.print(pulses[i][1] * RESOLUTION, DEC);
    Serial.print(F(", "));
    Serial.print(pulses[i+1][0] * RESOLUTION , DEC);
    Serial.print(F(","));
  }
  //Serial.print(F("\t")); // tab
  Serial.print(pulses[currentpulse-1][1] * RESOLUTION, DEC);
  Serial.print(F("};"));
  Serial.println("");
  Serial.println("");
  //////////////////

}
