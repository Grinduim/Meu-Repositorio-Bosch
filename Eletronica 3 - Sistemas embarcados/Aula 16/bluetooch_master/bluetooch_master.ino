String command = "";

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200); // serail normal
  Serial.println("Digite os comandos AT");

  Serial1.begin(115200); // inicinado o serail 19 e 18
  
}

void loop() {
  // put your main code here, to run repeatedly:

  if(Serial1.available()){
    while(Serial1.available())
    {
      command += (char)Serial1.read();
    }
    Serial1.println(command);
    command = ""; // no repeats
  }

  // read user input if available
  if(Serial.available())
  {
    delay(10);
    Serial1.write(Serial.read());
  }

}
