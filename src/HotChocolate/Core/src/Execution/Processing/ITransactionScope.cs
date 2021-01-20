using System;

namespace HotChocolate.Execution.Pipeline
{
    /// <summary>
    /// Represents a mutation transaction scope.
    /// </summary>
    public interface ITransactionScope : IDisposable
    {
        /// <summary>
        /// Completes a transaction (commits or discards the changes).
        /// </summary>
        void Complete();
    }
}
