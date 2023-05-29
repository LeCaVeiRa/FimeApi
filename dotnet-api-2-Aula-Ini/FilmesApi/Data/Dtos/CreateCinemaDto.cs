﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage ="O Campo Nome é obrigatorio")]
        public string Nome { get; set; }
    }
}
