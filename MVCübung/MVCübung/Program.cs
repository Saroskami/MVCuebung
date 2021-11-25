using System;

namespace MVC
{
    interface IObserver
    {
        
    }

    abstract class CModel : IObserver
    { }

    class PatientModel : CModel
    { }

    class Tableview : CModel
    { }

}