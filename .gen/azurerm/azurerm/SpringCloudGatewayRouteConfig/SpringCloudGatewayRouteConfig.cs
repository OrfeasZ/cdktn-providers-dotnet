using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudGatewayRouteConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_gateway_route_config azurerm_spring_cloud_gateway_route_config}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfig), fullyQualifiedName: "azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigConfig\"}}]")]
    public class SpringCloudGatewayRouteConfig : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_gateway_route_config azurerm_spring_cloud_gateway_route_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SpringCloudGatewayRouteConfig(Constructs.Construct scope, string id, azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudGatewayRouteConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudGatewayRouteConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a SpringCloudGatewayRouteConfig resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SpringCloudGatewayRouteConfig to import.</param>
        /// <param name="importFromId">The id of the existing SpringCloudGatewayRouteConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SpringCloudGatewayRouteConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SpringCloudGatewayRouteConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/spring_cloud_gateway_route_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SpringCloudGatewayRouteConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SpringCloudGatewayRouteConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putOpenApi", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApi\"}}]")]
        public virtual void PutOpenApi(azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigOpenApi @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigOpenApi)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigRoute" />)[]</param>
        [JsiiMethod(name: "putRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigRoute\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoute(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigRoute[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigRoute).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigRoute).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilters")]
        public virtual void ResetFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenApi")]
        public virtual void ResetOpenApi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredicates")]
        public virtual void ResetPredicates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoute")]
        public virtual void ResetRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpringCloudAppId")]
        public virtual void ResetSpringCloudAppId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsoValidationEnabled")]
        public virtual void ResetSsoValidationEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfig))!;

        [JsiiProperty(name: "openApi", typeJson: "{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApiOutputReference\"}")]
        public virtual azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApiOutputReference OpenApi
        {
            get => GetInstanceProperty<azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApiOutputReference>()!;
        }

        [JsiiProperty(name: "route", typeJson: "{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigRouteList\"}")]
        public virtual azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigRouteList Route
        {
            get => GetInstanceProperty<azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigRouteList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigTimeoutsOutputReference\"}")]
        public virtual azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.SpringCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filtersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? FiltersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openApiInput", typeJson: "{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigOpenApi\"}", isOptional: true)]
        public virtual azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigOpenApi? OpenApiInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigOpenApi?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predicatesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PredicatesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigRoute" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigRoute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RouteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "springCloudAppIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpringCloudAppIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "springCloudGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpringCloudGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssoValidationEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SsoValidationEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.SpringCloudGatewayRouteConfig.ISpringCloudGatewayRouteConfigTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.springCloudGatewayRouteConfig.SpringCloudGatewayRouteConfigTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "filters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Filters
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "predicates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Predicates
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "springCloudAppId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpringCloudAppId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "springCloudGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpringCloudGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "ssoValidationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object SsoValidationEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
