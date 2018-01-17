namespace AWSLambda1

open Amazon.Lambda.Core

type Function() =
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    member _this.FunctionHandler (input: string) (_: ILambdaContext) =
        match input with
        | null -> ""
        | v -> v.ToUpper()