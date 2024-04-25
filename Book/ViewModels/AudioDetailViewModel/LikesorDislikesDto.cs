

namespace ViewModels.AudioDetailViewModel;

public class LikesorDislikesDto
{
    public int Id { get; set; }  
    public long? Likes { get; set; } = 0;
    public long? Dislikes { get; set; } = 0;
}
