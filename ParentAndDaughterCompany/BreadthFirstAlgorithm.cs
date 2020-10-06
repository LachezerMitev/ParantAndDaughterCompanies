using System;
using System.Collections.Generic;
using System.Text;

namespace ParentAndDaughterCompany
{
    class BreadthFirstAlgorithm
    {
        private Queue<Company> _queue = new Queue<Company>();
        private HashSet<Company> _hash = new HashSet<Company>();
        private string _companyStartName { get; set; }

        private void Init(Company start)
        {
            _queue.Enqueue(start);
            _hash.Add(start);
            _companyStartName = start.name;
        }

        private void Reset()
        {
            _queue = new Queue<Company>();
            _hash = new HashSet<Company>();
        }

        public void SearchIterrative(Company start, Company companyToSearchFor)
        {
            Init(start);

            while (_queue.Count > 0)
            {
                Company currentCompany = _queue.Dequeue();
                if (currentCompany.name == companyToSearchFor.name)
                {
                    Reset();
                    Console.WriteLine($"{start.name} has a connection with {companyToSearchFor.name}");
                    return;
                }
                foreach (Company daughterCompany in currentCompany.Companies)
                {
                    if (!_hash.Contains(daughterCompany))
                    {
                        _queue.Enqueue(daughterCompany);
                        _hash.Add(daughterCompany);
                    }
                }
            }

            Reset();
            Console.WriteLine($"Connection between {start.name} and {companyToSearchFor.name} not found");
        }

        public void SearchRecursive(Company start, Company companyToSearchFor, bool init)
        {
            if (init)
                Init(start);

            if (_queue.Count != 0)
            {
                Company currentCompany = _queue.Dequeue();
                if (currentCompany.name == companyToSearchFor.name)
                {
                    Reset();
                    Console.WriteLine($"{_companyStartName} has a connection with {companyToSearchFor.name}");
                    return;
                }
                else
                {
                    foreach (Company daughterCompany in currentCompany.Companies)
                    {
                        if (!_hash.Contains(daughterCompany))
                        {
                            _queue.Enqueue(daughterCompany);
                            _hash.Add(daughterCompany);
                        }
                    }
                    SearchRecursive(currentCompany, companyToSearchFor, false);
                    return;
                }
            }
            Reset();
            Console.WriteLine($"Connection between {_companyStartName} and {companyToSearchFor.name} not found");
            return;
        }
    }
}
