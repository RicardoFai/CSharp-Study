bool p = true;
bool q = true;


Console.WriteLine($"não {p} = {!p}"); // Operador lógico de negação
Console.WriteLine($"{p} e {q} = {p && q}"); // Operador lógico de conjunção (AND) - retorna true se ambos os operandos forem true
Console.WriteLine($"{p} ou {q} = {p || q}");// Operador lógico de disjunção (OR) - retorna true se pelo menos um dos operandos for true