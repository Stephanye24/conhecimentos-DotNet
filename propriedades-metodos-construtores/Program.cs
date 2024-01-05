using propriedades_metodos_construtores.Models;


Pessoa p1 = new("Stephanye", "Vasconcellos");
Pessoa p2 = new(nome: "Stephanye", sobrenome: "Vasconcellos");

Curso cursoDeIngles = new()
{
    Nome = "Inglês",
    Alunos = []
};

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
