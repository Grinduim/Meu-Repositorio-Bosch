#include <Servo.h>
Servo servo;
int pot = A1;

void setup() {
  // put your setup code here, to run once:
  servo.attach(9);
  pinMode(pot,INPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  int angulo = map(analogRead(pot),0,1023,0,180);
  servo.write(angulo);

}
