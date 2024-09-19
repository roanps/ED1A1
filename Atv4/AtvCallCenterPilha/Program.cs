using AtvCallCenterPilha;

//Random random = new Random();

CallCenter center = new CallCenter();

Stack<int> stack = new Stack<int>();

while(2>1){
    Console.WriteLine("Digite 1 para iniciar um novo chamado ou qualquer número para finalizar o programa:\n");
     int input = Convert. ToInt32(Console. ReadLine()); 
    if(input == 1){

        center.Call(1234);
        Console.WriteLine("Chamado adicionado");

        IncomingCall call = center.Answer("Thiago");
        Console.WriteLine(
            @$"{DateTime.Now:HH:mm;ss} 
            Chamado: #{call.Id}
            De: {call.ClientId}
            Atendido por: {call.Consultant}"
         );

    }else{
        Console.WriteLine("Encerrando programa");
        break;
    }    
    
}

/*
center.Call(1234);

while(center.AreWaitingCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(
        @$"{DateTime.Now:HH:mm;ss} 
            Chamado: #{call.Id}
            De: {call.ClientId}
            Atendido por: {call.Consultant}"
    );
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$" Chamado: {call.Id}
            Encerrado às: {call.EndTime}"
    );
}*/