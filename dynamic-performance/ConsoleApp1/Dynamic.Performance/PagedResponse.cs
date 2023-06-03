namespace Dynamic.Performance;

public class PagedResponse<T>
{
    public T[] Items { get; set; }

    public int PageSize { get; set; }

    public int PageNumber { get; set; }
}