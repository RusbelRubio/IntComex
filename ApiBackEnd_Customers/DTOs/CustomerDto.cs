#nullable disable

using Swashbuckle.AspNetCore.Annotations;

namespace ApiBackEnd_Customers.DTOs;

public class CustomerDto
{
    [SwaggerSchema(ReadOnly = true)]
    public int IdUserInf { get; set; }

    public string UserInf { get; set; }

    public string NameInf { get; set; }

    public string TitleInf { get; set; }

    public string CellphoneInf { get; set; }

    public string EmailInf { get; set; }

    public string ContactTypeInf { get; set; }
}
