using MediatR;

namespace RO.DevTest.Application.Features.Auth.Commands.LoginCommand {
    public class CreateUserCommand : IRequest<CreateUserResponse>
    {
        public string Username { get; set; } = default;
        public string Password { get; set; } = default;
        public string Role { get; set; } = default;
    }
}