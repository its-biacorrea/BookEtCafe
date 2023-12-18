using System;

namespace BookEtCafe.Models;
public class Editora
{
	public int EditoraId { get; set; }
	public string EditoraNome { get; set;}
	public ICollection<Livro>? Livros { get; set;}

}
