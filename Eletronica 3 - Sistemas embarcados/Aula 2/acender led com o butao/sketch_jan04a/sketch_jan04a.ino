int Led1 = 2;
int Led2 = 7;
int button = 4;

void setup() {
  // put your setup code here, to run once:
  pinMode(Led1,OUTPUT);
  pinMode(Led2,OUTPUT);
  pinMode(button,INPUT_PULLUP);
  Serial.begin(9600);
}

void loop() {
  digitalWrite(Led1,LOW);
  digitalWrite(Led2,HIGH);
  int press = digitalRead(button);
  if( press < HIGH){
    digitalWrite(Led1,HIGH);
    digitalWrite(Led2,LOW);
    delay(2000);
  }
  
}
