using Json_ignore;
using System.Text.Json;
using System.Text.Json.Serialization;

Employee employee = new()
{
    ID = 1,
    Name = "Jhon",
    City = "G-City"

};

/*
 * Json Serialization without options
 */

string empJson = JsonSerializer.Serialize(employee);

Console.WriteLine(empJson);

/*Output
 * {"ID":1,"Name":"Jhon","City":"G-Capital","RefIdReadOnly":1013}
 */



/*
 * Json Serialization - To ignore individual properties 
 * City - JsonIgnore
 */

empJson = JsonSerializer.Serialize(employee);

Console.WriteLine(empJson);

/*Output
 * {"ID":1,"Name":"Jhon","RefIdReadOnly":1013}
 */


/*
 * We can specify conditional exclusion by setting the [JsonIgnore] attribute's Condition property
 * City - null
 * JsonIgnoreCondition.WhenWritingDefault, 
 *  JsonIgnoreCondition.WhenWritingNull
 */

empJson = JsonSerializer.Serialize(employee);

Console.WriteLine(empJson);

/* Output 
 * {"Name":"Jhon","RefIdReadOnly":1013}
 */


/*
 * Ignore all read-only properties
 * 
 */

var options = new JsonSerializerOptions
{

    IgnoreReadOnlyProperties = true

};
empJson = JsonSerializer.Serialize(employee, options);

Console.WriteLine(empJson);

/* Output 
 * {"ID":0,"Name":"Jhon","City":"G-Capital"}
 */



/*
 * Ignore all null-value properties
 * Pass city = null
 */

JsonSerializerOptions jsonSerializerOptions = new()
{
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
};

empJson = JsonSerializer.Serialize(employee, jsonSerializerOptions);

Console.WriteLine(empJson);

/* Output 
 * {"ID":0,"Name":"Jhon","RefIdReadOnly":1013}
 */



