using CodeFramework.ViewControllers;
using CodeHub.Core.ViewModels.Source;
using MonoTouch.Dialog;

namespace CodeHub.iOS.Views.Source
{
    public class ChangesetBranchesView : ViewModelCollectionDrivenViewController
    {
        public override void ViewDidLoad()
        {
            Title = "Changeset Branch".t();
            SearchPlaceholder = "Search Branches".t();
            NoItemsText = "No Branches".t();

            base.ViewDidLoad();

            var vm = (ChangesetBranchesViewModel) ViewModel;
            BindCollection(vm.Branches, x => new StyledStringElement(x.Name, () => vm.GoToBranchCommand.Execute(x)));
        }
    }
}

