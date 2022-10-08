using System;
 
class Program {
 public static int Main() {
  for(int i=0; i<=20; i++) {
   if(i%2 == 0) {
    Console.Write("{0} ", i);
   }
  }
  Console.ReadKey();
  return 0;
 }
}
