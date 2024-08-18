using MyMLApp;


Console.WriteLine("Digite uma frase para analisarmos seu feedback: ");
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = Console.ReadLine()
};


var result = SentimentModel.Predict(sampleData);


var sentiment = result.PredictedLabel == 1 ? "Ótimo feedback" : "Feedback ruim";
Console.WriteLine($"Texto: {sampleData.Col0}\nSentimento: {sentiment}");