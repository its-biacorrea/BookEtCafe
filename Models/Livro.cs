using System;
using System.ComponentModel.DataAnnotations;

public class Livro
{
    public int LivroId { get; set; }

    [Required(ErrorMessage = "Campo obrigatório.")]
    [StringLength(50, ErrorMessage = "Número máximo de caracteres atingido")]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [Required(ErrorMessage = "Campo obrigatório.")]
    public string Sinopse { get; set; }

    [Required(ErrorMessage = "Campo obrigatório.")]
    [Display(Name = "Caminho URL da imagem")]
    public string ImagemUri { get; set; }

    [Required(ErrorMessage = "Campo obrigatório.")]
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }

    [Required(ErrorMessage = "Campo obrigatório.")]
    [Display(Name = "Disponível")]
    public bool Disponivel { get; set; }
    public string DisponivelFormatado => Disponivel ? "Sim" : "Não";

    [Required(ErrorMessage = "Campo obrigatório.")]
    [Display(Name = "Data de Entrega")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [DataType("day")]
    public DateTime DataDeEntrega { get; set; }

    [Display(Name = "Editora")]
    public int? EditoraId { get; set; }



}
