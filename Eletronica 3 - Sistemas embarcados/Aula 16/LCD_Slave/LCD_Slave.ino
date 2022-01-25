
#include <LiquidCrystal.h>
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

String receivestring_ch;
String temp_ch;
String hum_ch;


void setup()
{
   lcd.begin(16, 2);
   Serial.begin(9600);

}

void loop()
{

 while(Serial.available()){ 
    delay(10);
    if (Serial.available() >0) {
           char c = Serial.read();   // lendo char por char                  // gets one byte from serial buffer
           receivestring_ch += c;    // adcionando esse char em um vetor                      // construct the recievestring_ch
       }
    }
    
 if (receivestring_ch.length() >0) {
     Serial.print("receivestring_ch = ");             
     Serial.println(receivestring_ch);                  

     temp_ch = receivestring_ch.substring(0, 4);     //repartindo esse vetor de char para pegar cada valores 
     hum_ch = receivestring_ch.substring(5, 9); 

     receivestring_ch = ""; //  
     Serial.print("Temperatura = ");                       
     Serial.println(temp_ch);                  
     Serial.print("Humidade = ");                 
     Serial.println(hum_ch);               
     Serial.println();                   

     float temp = 0.00;                        
     float hum = 0.00;                     

     
     char carray1[6];                                  
     temp_ch.toCharArray(carray1, sizeof(carray1)); // char para array para poder print no lcd
     temp = atof(carray1); // array para float
     
     char carray2[6];
     hum_ch.toCharArray(carray2, sizeof(carray2));
     hum = atof(carray2);

  {
  
 }
 // printando as informações no txt
   lcd.setCursor(0, 0);
   lcd.print(temp, 2);
   
   lcd.setCursor(0, 1);     
   lcd.print(hum, 2);

   temp = 0;
   hum = 0;

   delay(1000);
  
}
}





  
