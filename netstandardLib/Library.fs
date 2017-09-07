namespace sssssss

module Say =
    let hello name =
        let jc = Newtonsoft.Json.JsonConvert.SerializeObject("")
        printfn "Hello %s" name
