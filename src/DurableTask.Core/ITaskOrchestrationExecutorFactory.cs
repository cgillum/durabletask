using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurableTask.Core
{
    // TODO: Doc comments
    public interface ITaskOrchestrationExecutorFactory
    {
        TaskOrchestrationExecutor GetExecutor(OrchestrationRuntimeState runtimeState, TaskOrchestration taskOrchestration);
    }
}
