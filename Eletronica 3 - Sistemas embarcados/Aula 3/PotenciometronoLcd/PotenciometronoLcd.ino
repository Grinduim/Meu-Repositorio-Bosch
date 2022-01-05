#include <LiquidCrystal.h>

int Pot = A3;
LiquidCrystal lcd(12,11,5,4,3,2);
void setup() {
  // put your setup code here, to run once:
  pinMode(Pot,INPUT);
  lcd.begin(16,2);
  lcd.clear();
  

}

void loop() {
  // put your main code here, to run repeatedly:
  int leitura = analogRead(Pot);
  leitura = map(leitura,0,1023,0,255);
  
  lcd.clear();
  lcd.setCursor(0,0);
  lcd.print(leitura);
  delay(800);
}
