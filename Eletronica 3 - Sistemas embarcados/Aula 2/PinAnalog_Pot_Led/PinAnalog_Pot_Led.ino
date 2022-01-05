int PinLed = 9; // led
int Pisca = 5;
int Poten = A3;
int val  = 0;


void setup() {
  pinMode(PinLed,OUTPUT);
  pinMode(Pisca,OUTPUT);
  pinMode(Poten,INPUT);
  Serial.begin(9600);
}

void loop() {
//   put your main code here, to run repeatedly:
  val =  analogRead(Poten);
  //analogWrite(PinLed,val/4);

  int TempoDeEspera = map(val,0,1023,50,800);
   Serial.println(TempoDeEspera);
  digitalWrite(Pisca,HIGH);
  delay(TempoDeEspera);
  digitalWrite(Pisca,LOW);
  delay(TempoDeEspera);
}
