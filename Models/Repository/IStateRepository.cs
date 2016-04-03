using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularExample.Models.Repository
{
    public interface IStateRepository
    {
        State CreateState(State stateToCreate);
        void DeleteState(int id);
        State UpdateState(int id, State stateToUpdate);
        State GetStateById(int id);
        IEnumerable<State> GetStates();
    }
}
