using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;

namespace PokeWpfWithAPI
{
    internal class ViewModel : BindableBase
    {
        private Model m;
        private string _surchInputInput;
        private ObservableCollection<Pokemon> _pokeList = new ObservableCollection<Pokemon>();
        private bool _isEnabled;


        public ObservableCollection<Pokemon> PokeList
        {
            get => _pokeList;
            set => SetProperty(ref _pokeList, value);
        }
        public string SurchInput
        {
            get => _surchInputInput;
            set => SetProperty(ref _surchInputInput, value);
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set { SetProperty(ref _isEnabled, value);
                ((DelegateCommand)CancelCommand).RaiseCanExecuteChanged();
            }
        }

        public ICommand SuchCommand {get;}
        public ICommand CancelCommand { get; }

        public ViewModel()
        {
            m = new Model();
            SuchCommand = new DelegateCommand(Surch);
            CancelCommand = new DelegateCommand(Cancel, () => IsEnabled);
            foreach (var pokemon in m.PokeList)
            {
                PokeList.Add(pokemon);
            }
        }

        public void Surch()
        {
            ObservableCollection<Pokemon> tempList = new ObservableCollection<Pokemon>();
            foreach (var pokemon in m.PokeList)
            {
                if (pokemon.Name.Contains(SurchInput) || pokemon.Id.Contains(SurchInput))
                {
                    tempList.Add(pokemon);
                }
            }
            if (tempList.Count == 0) tempList.Add(new Pokemon(SurchInput, "Hab ich leider nicht gefunden", "Traurig/Ich werde mich bessern"));
            PokeList.Clear();
            PokeList = tempList;
            IsEnabled = true;
            SurchInput = null;
        }

        public void Cancel()
        {
            PokeList.Clear();
            foreach (var pokemon in m.PokeList)
            {
                PokeList.Add(pokemon);
            }

            IsEnabled = false;
        }
    }
}
