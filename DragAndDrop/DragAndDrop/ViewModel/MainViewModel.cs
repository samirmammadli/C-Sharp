using DragAndDrop.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DragAndDrop.ViewModel
{
    public class ObservableCollectionEx<T> : ObservableCollection<T> where T : INotifyPropertyChanged
    {
        // this collection also reacts to changes in its components' properties

        public ObservableCollectionEx() : base()
        {
            this.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(ObservableCollectionEx_CollectionChanged);
        }

        void ObservableCollectionEx_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (T item in e.OldItems)
                {
                    //Removed items
                    item.PropertyChanged -= EntityViewModelPropertyChanged;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (T item in e.NewItems)
                {
                    //Added items
                    item.PropertyChanged += EntityViewModelPropertyChanged;
                }
            }
        }

        public void EntityViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //This will get called when the property of an object inside the collection changes - note you must make it a 'reset' - dunno why
            NotifyCollectionChangedEventArgs args = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
            OnCollectionChanged(args);
        }
    }



    class MainViewModel : ViewModelBase//, IDropTarget
    {
        public ObservableCollectionEx<Person> Persons1 { get; set; }
        public ObservableCollectionEx<Person> Persons2 { get; set; }
        public ObservableCollectionEx<Person> Persons3 { get; set; }
        public ObservableCollectionEx<Person> SelectedItems { get; set; }

        private Person _selected;

        public Person Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        private RelayCommand _deletePerson;

        public RelayCommand DeletePerson
        {
            get
            {
                return _deletePerson ?? (_deletePerson = new RelayCommand(() => Persons1.Remove(Selected)));
            }
        }

        private RelayCommand _changeName;

        public RelayCommand ChangeName
        {
            get
            {
                return _changeName ?? (_changeName = new RelayCommand(() => Selected.Name = "dqwdw"));
            }
        }


        public MainViewModel()
        {
            Persons1 = new ObservableCollectionEx<Person>();
            Persons2 = new ObservableCollectionEx<Person>();
            Persons3 = new ObservableCollectionEx<Person>();

            var rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                Persons1.Add(new Person($"First", i+ 1));
                Persons2.Add(new Person($"Second", i + 1));
                Persons3.Add(new Person($"Third", i + 1));
            }
        }

        //void IDropTarget.DragOver(IDropInfo dropInfo)
        //{
        //    dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
        //    dropInfo.Effects = DragDropEffects.Move;
        //    //MessageBox.Show(dropInfo.TargetItem.ToString());
        //    //throw new NotImplementedException();
        //}

        //void IDropTarget.Drop(IDropInfo dropInfo)
        //{
        //    //MessageBox.Show(dropInfo.TargetCollection.ToString());

        //    var sourceItem = dropInfo.Data as Person;
        //    var targeCollection = dropInfo.TargetCollection as ObservableCollection<Person>;
        //    var index = targeCollection.IndexOf(dropInfo.TargetItem as Person);
        //    targeCollection.Insert(index, sourceItem);
        //    //targeCollection.Add(sourceItem);
        //    //throw new NotImplementedException();
        //}
    }
}
