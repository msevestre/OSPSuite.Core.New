using OSPSuite.Core.Commands.Core;

namespace OSPSuite.UI.Helpers
{

   public class MyContext
   {
   }

   public class MySimpleCommand : Command, ICommand<MyContext>
   {
      public void Execute(MyContext context)
      {
      }

      public void RestoreExecutionData(MyContext context)
      {
      }
   }

}