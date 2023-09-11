// See https://aka.ms/new-console-template for more information
abstract class Hospital{
    public abstract void d();
    public abstract void n();
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
    public override void n(){
        Console.WriteLine("50 nurses");
    }
    
}

 class Program
 {
   public static void Main(string[] args){
    
   Project Ref=new Project();
   Ref.d();
   Ref.numofbeds();
   Ref.n();
    }
}


