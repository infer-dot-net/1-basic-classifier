// https://dotnet.github.io/infer/userguide/Two%20coins%20tutorial.html
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.ML.Probabilistic.Models;
using Microsoft.ML.Probabilistic.Algorithms;
using Microsoft.ML.Probabilistic.Compiler;
using Microsoft.ML.Probabilistic.Distributions;

namespace TwoCoins
{

    class Program
    {
        static void Main(string[] args)
        {
            Variable<bool> firstCoin = Variable.Bernoulli(0.5).Named("firstCoin");
            Variable<bool> secondCoin = Variable.Bernoulli(0.5).Named("secondCoin");
            Variable<bool> bothHeads = (firstCoin & secondCoin).Named("bothHeads");


            /********* observations *********/
            // bothHeads.ObservedValue = true;
            secondCoin.ObservedValue = true;
            /*******************************/

            /********** inference **********/
            var InferenceEngine = new InferenceEngine();
            
            InferenceEngine.NumberOfIterations = 50;
            // InferenceEngine.ShowFactorGraph = true;

            Bernoulli postBothHeads = InferenceEngine.Infer<Bernoulli>(bothHeads);
            /*******************************/

            Console.WriteLine(postBothHeads);

            // write outputs to file
            // var results = new StringBuilder();

            // results.AppendLine("variable;mean;variance");
            // var line = string.Format("postWeight;{0};{1}", postWeight.GetMean(), postWeight.GetVariance());
            // results.AppendLine(line.Replace(',', '.'));
            // line = string.Format("postThreshold;{0};{1}", postThreshold.GetMean(), postThreshold.GetVariance());
            // results.AppendLine(line.Replace(',', '.'));

            // File.WriteAllText(dataDir + "results.csv", results.ToString());
            
            // bothHeads.ObservedValue = true;
            // Console.WriteLine("Probability distribution over firstCoin: " + engine.Infer(firstCoin));

            // engine.ShowFactorGraph = true;
            // engine.ShowMsl = true;
        }
    }
}