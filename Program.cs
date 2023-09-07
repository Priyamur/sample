// See https://aka.ms/new-console-template for more information
abstract class Hospital{
    public abstract void d();
    public void numofbeds(){
       Console.WriteLine("100");
  }

}
class Project : Hospital
{
    public override void d(){
        Console.WriteLine("Doctors: Nithiya");
        Console.WriteLine("second Doctor Priya");
    }
    
}

 class Program
 {
   public static void Main(string[] args){
    
   Project Ref=new Project();
   Ref.d();
   Ref.numofbeds();
    }
}


