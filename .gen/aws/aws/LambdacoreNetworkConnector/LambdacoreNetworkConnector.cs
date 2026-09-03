using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdacoreNetworkConnector
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector aws_lambdacore_network_connector}.</summary>
    [JsiiClass(nativeType: typeof(aws.LambdacoreNetworkConnector.LambdacoreNetworkConnector), fullyQualifiedName: "aws.lambdacoreNetworkConnector.LambdacoreNetworkConnector", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfig\"}}]")]
    public class LambdacoreNetworkConnector : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector aws_lambdacore_network_connector} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdacoreNetworkConnector(Constructs.Construct scope, string id, aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdacoreNetworkConnector(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdacoreNetworkConnector(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a LambdacoreNetworkConnector resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LambdacoreNetworkConnector to import.</param>
        /// <param name="importFromId">The id of the existing LambdacoreNetworkConnector that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LambdacoreNetworkConnector to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LambdacoreNetworkConnector to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LambdacoreNetworkConnector that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LambdacoreNetworkConnector to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.LambdacoreNetworkConnector.LambdacoreNetworkConnector), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfiguration" />)[]</param>
        [JsiiMethod(name: "putConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
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
        = GetStaticProperty<string>(typeof(aws.LambdacoreNetworkConnector.LambdacoreNetworkConnector))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationList\"}")]
        public virtual aws.LambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationList Configuration
        {
            get => GetInstanceProperty<aws.LambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorTimeoutsOutputReference\"}")]
        public virtual aws.LambdacoreNetworkConnector.LambdacoreNetworkConnectorTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LambdacoreNetworkConnector.LambdacoreNetworkConnectorTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operatorRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperatorRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operatorRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatorRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
