/*
 * GUID:e6c09dfe-3a3e-461b-b3f9-734aee05fc7b
 * 
 * Coded by fiyistack.com
 * Copyright © 2024
 * 
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Software.
 * 
 */

namespace JuanApp2.Areas.System.FailureBack.Entities
{
    public class Failure
    {
        public int FailureId { get; set; }

        public bool Active { get; set; }

        public DateTime DateTimeCreation { get; set; }

        public DateTime DateTimeLastModification { get; set; }

        public int UserCreationId { get; set; }

        public int UserLastModificationId { get; set; }

        public string? Message { get; set; }

        public int EmergencyLevel { get; set; }

        public string? StackTrace { get; set; }

        public string? Source { get; set; }

        public string? Comment { get; set; }
    }
}