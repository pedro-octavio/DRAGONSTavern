using System;
using System.ComponentModel.DataAnnotations;

namespace DRAGONSTavern.Domain.ValueObjects
{
    public abstract class Shared
    {
        protected Shared(string id) => Id = id ?? Guid.NewGuid().ToString().Replace("-", "").Substring(1, 10);

        [Key]
        [MaxLength(10)]
        public string Id { get; private set; }

        public void GenerateId()
        {
            Id = Guid.NewGuid().ToString().Replace("-", "").Substring(1, 10);
        }
    }
}
