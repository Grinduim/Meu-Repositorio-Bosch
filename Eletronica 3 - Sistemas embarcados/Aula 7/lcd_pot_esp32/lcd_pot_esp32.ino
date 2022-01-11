#include <LiquidCrystal.h>
                 //2  4  19  21 22 23  
LiquidCrystal lcd (19,23,18,17,16,15);

int pir = 21;
void setup() {
  // put your setup code here, to run once:
  lcd.begin(16,2);
  lcd.clear();
  pinMode(pir, INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  lcd.clear();
  
  if(digitalRead(pir) == HIGH){
     lcd.setCursor(2,0);
     lcd.print("Movimento");
  }
  else
  {
  lcd.setCursor(2,0);
  lcd.print("Aaaa");
  }
  delay(5000);
}
