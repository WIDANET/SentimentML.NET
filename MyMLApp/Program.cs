using MyMLApp;


Console.WriteLine("Vai zbct, digita alguma coisa aí:");
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = Console.ReadLine()
};


var result = SentimentModel.Predict(sampleData);


var sentiment = result.PredictedLabel == 1 ? "Pica de cachorro" : "vsfd horrivel Kjkkkkkk";
Console.WriteLine($"Texto: {sampleData.Col0}\nSentimento: {sentiment}");