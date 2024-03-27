using DelegateFirstTaskHW;

DelegateClass delegateClass = new DelegateClass();
DelegateClass.NoParameters noparam = new DelegateClass.NoParameters(delegateClass.RunRandomNumbers);
Console.WriteLine(noparam());
