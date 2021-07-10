using System;

namespace exercicio015.Entities.Exceptions {
    class DomainException : ApplicationException {
        // ApplicationException é uma forma de personalizar os tratamentos de erros
        // Em vez de usar o SystemException
        public DomainException(string message) : base(message) {

        }
    }
}
