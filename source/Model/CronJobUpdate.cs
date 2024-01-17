using API.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace API.Model;

public sealed record CronJobUpdate
{
    [Required]
    public long Id { get; init; }

    public string Uri { get; init; }

    public HttpMethodEnum HttpMethod { get; init; }

    public string Body { get; init; }

    public string Schecule { get; init; }

    public string TimeZone { get; init; }
}