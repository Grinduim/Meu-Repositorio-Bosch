#include <LiquidCrystal.h>


int Mov = 13;

LiquidCrystal lcd(12,11,5,4,3,2);

void setup() {
  // put your setup code here, to run once:
  pinMode(Mov,INPUT);
  lcd.begin(16,2);
  lcd.clear();
  lcd.setCursor(2,0);
  Serial.begin(9600);

}

void loop() {
  // put your main code here, to run repeatedly:
  lcd.setCursor(2,0);
  Serial.println(digitalRead(Mov));
  if(digitalRead(Mov) == HIGH){
    lcd.print("Movimento");
    delay(1500);
  }
  else{
    lcd.clear();
  }
}
