int vetor[] = {2,9,5,7,6,4,11,10,1,3,8};

void setup() {
  // put your setup code here, to run once:
  int i = 0;   for(i = 3; i < 14; i ++){
    pinMode(i,OUTPUT);
  }

}

void loop() {
  // put your main code here, to run repeatedly:
  int i;
  delay(1500);
  for(i = 0; i < 11; i ++){
    digitalWrite(vetor[i]+2,HIGH);
    delay(1000);  
  }
  delay(5000);
  for(i = 10; i > -0; i--){
    digitalWrite(vetor[i]+2,LOW);
    delay(1000); 
  }
  
} 
