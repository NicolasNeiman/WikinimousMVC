using System;
using System.ComponentModel.DataAnnotations;

namespace WikinimousMVC.Models
{
  public class Comment
  {
    public int Id { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    [DataType(DataType.Date)]
    public DateTime CommentDate { get; set; }

    public int PostId { get; set; }
    public Post Post { get; set; }
  }
}