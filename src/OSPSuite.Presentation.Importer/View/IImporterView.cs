using System.Collections.Generic;
using OSPSuite.Assets;
using OSPSuite.Core.Importer;
using OSPSuite.Core.Services;
using OSPSuite.Presentation.Presenters.Importer;

namespace OSPSuite.Presentation.Views.Importer
{
   public interface IImporterView : IModalView<IImporterPresenter>
   {
      void StartImport(string sourceFile, ImportTableConfiguration importTableConfiguration, Mode mode);
      IList<ImportDataTable> Imports { get; }
      ViewResult ShowDialog();
      void SetIcon(ApplicationIcon icon);
      void SetNamingView(IView view);
   }
}