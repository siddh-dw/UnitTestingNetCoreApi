using System;
using Xunit;
using unitTesting.Controllers;
using unitTesting.models.Services;
using unitTesting.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using unitTesting.Models;

namespace Testing;

public class EmployerTesting
{
    private readonly EmployerController _controller;
    private readonly IEmployerServices _service;
    
    public EmployerTesting()
    {
       _service = new EmployerService();
       _controller = new EmployerController(_service);
        
    }

    [Fact]
    public void Get_Ok()
    {
        var result = _controller.Get();

        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void Get_Quantity()
    {
        var result = (OkObjectResult)_controller.Get();
        var employers = Assert.IsType<List<Employer>>(result.Value);
        Assert.True(employers.Count > 0);
    }

    [Fact]
    public void GetById_Ok()
    {
        int id = 1;
        var result =(OkObjectResult)_controller.GetById(id);
        var employer = Assert.IsType<Employer>(result?.Value);
        Assert.True(employer != null);
        Assert.Equal(employer?.Id, id);

    }

        [Fact]
    public void GetById_NotFound()
    {
        int id = 5;

        var result = _controller.GetById(id);
        var employer = Assert.IsType<NotFoundResult>(result);

    }
}