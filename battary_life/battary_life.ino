int data;  

void setup() {  
    Serial.begin(9600);  
    pinMode(12, OUTPUT);  
}  



void loop() 
{  
    if (Serial.available()) 
    {  
        data = Serial.read();
          
        if (data == 'A') {  
            digitalWrite(12, HIGH);  
        } 
        
        if (data == 'B')
        {  
            digitalWrite(12, LOW);  
        }
          
    }  
}  
