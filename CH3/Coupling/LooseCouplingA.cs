using System.Diagnostics;

namespace CH3.Coupling
{
    /// <summary>
    /// This class demonstrates an example of loose coupling.
    /// </summary>
    public class LooseCouplingA
    {
        /// <summary>
        /// The private modifier prevents access to the data member.
        /// </summary>
        private string _name;
        private readonly string _stringIsEmpty = "String is empty";

        /// <summary>
        /// The property enables the data member to be indirectly accessed.
        /// Validation takes place upon getting or setting the data member.
        /// The internals can be changed without affecting the classes
        /// that access it.
        /// </summary>
        public string Name
        {
            get
            {
                if (_name.Equals(string.Empty))
                    return _stringIsEmpty;
                else
                    return _name;
            }

            set
            {
                if (value.Equals(string.Empty))
                    Debug.WriteLine("Exception: String length must be greater than zero.");
            }
        }
    }
}
