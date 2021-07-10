using System;

namespace programa40.Entities.Exceptions {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {

        }
    }
}
