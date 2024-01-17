using API.Model.Enums;

namespace API.Model;

public sealed record CronJobDTO
{
    public long Id { get; init; }

    public string Uri { get; init; }

    public HttpMethodEnum HttpMethod { get; init; }

    public string Body { get; init; }

    public string Schecule { get; init; }

    public string TimeZone { get; init; }
}
