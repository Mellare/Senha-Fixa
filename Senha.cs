bool validarSenha = true;

while(validarSenha){
int senha = int.Parse(Console.ReadLine());

if(senha == 2002){
    Console.WriteLine("Acesso Permitido");
    validarSenha = false;
} else {
    Console.WriteLine("Senha Invalida");
}

}
