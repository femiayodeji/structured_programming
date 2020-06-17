namespace Mediator.Models
{
    public abstract class User
    {
        protected readonly IMediator _mediator;

        public User(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}