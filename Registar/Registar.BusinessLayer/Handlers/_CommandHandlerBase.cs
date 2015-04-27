using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registar.BusinessLayer.Contracts;

namespace Registar.BusinessLayer.Handlers
{
    /// <summary>
    /// Abstract class for all command handlers
    /// Kllasata e zamislena kako abstract klasa koja prima nekakva komanda i vraka
    /// rezultat za taa komanda
    /// </summary>
    public abstract class CommandHandlerBase<TRequest, TResult> : IHandler
        where TRequest : Command
        where TResult : CommandResult
    {
        /// <summary>
        /// method that execute the command
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected abstract TResult ExecuteCommand(TRequest command);

        public CommandResult Execute(Command command)
        {
            return ExecuteCommand((TRequest)command);
        }
    }
    /// <summary>
    /// Interface koj ima edna metoda koja ke bide javna za site - EXECUTE
    /// </summary>
    internal interface IHandler
    {
        CommandResult Execute(Command command);
    }
}
