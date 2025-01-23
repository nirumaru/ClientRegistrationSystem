using System;
using Xunit;
using ClientRegistrationSystem.Models;
using ClientRegistrationSystem.Repositories;

public class ClientRepositoryTests
{
    [Fact]
    public void CreateClient_ValidClient_DoesNotThrowException()
    {
        // Arrange
        var clientRepository = new ClientRepository();
        var client = new Client
        {
            name = "Test Client",
            email = "test@example.com",
            phonenumber = "1234567890",
            address = "123 Test Street",
            category = "Test Category"
        };

        // Act & Assert
        var exception = Record.Exception(() => clientRepository.CreateClient(client));
        Assert.Null(exception); // Assert that no exception is thrown
    }

    [Fact]
    public void CreateClient_EmptyClient_DoesNotThrowException()
    {
        // Arrange
        var clientRepository = new ClientRepository();
        var client = new Client(); // Empty client object

        // Act & Assert
        var exception = Record.Exception(() => clientRepository.CreateClient(client));
        Assert.Null(exception); // Assert that no exception is thrown
    }
}
