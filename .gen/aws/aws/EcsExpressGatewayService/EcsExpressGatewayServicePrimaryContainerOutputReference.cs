using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsExpressGatewayService
{
    [JsiiClass(nativeType: typeof(aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerOutputReference), fullyQualifiedName: "aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcsExpressGatewayServicePrimaryContainerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public EcsExpressGatewayServicePrimaryContainerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsExpressGatewayServicePrimaryContainerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsExpressGatewayServicePrimaryContainerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAwsLogsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAwsLogsConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnvironment", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerEnvironment\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnvironment(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerEnvironment[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerEnvironment).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerEnvironment).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepositoryCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentials\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRepositoryCredentials(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerRepositoryCredentials).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerSecret\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecret(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerSecret[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerSecret).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainerSecret).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsLogsConfiguration")]
        public virtual void ResetAwsLogsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommand")]
        public virtual void ResetCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerPort")]
        public virtual void ResetContainerPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryCredentials")]
        public virtual void ResetRepositoryCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecret")]
        public virtual void ResetSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "awsLogsConfiguration", typeJson: "{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfigurationList\"}")]
        public virtual aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfigurationList AwsLogsConfiguration
        {
            get => GetInstanceProperty<aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfigurationList>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerEnvironmentList\"}")]
        public virtual aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerEnvironmentList Environment
        {
            get => GetInstanceProperty<aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerEnvironmentList>()!;
        }

        [JsiiProperty(name: "repositoryCredentials", typeJson: "{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentialsList\"}")]
        public virtual aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentialsList RepositoryCredentials
        {
            get => GetInstanceProperty<aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentialsList>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerSecretList\"}")]
        public virtual aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerSecretList Secret
        {
            get => GetInstanceProperty<aws.EcsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerSecretList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsLogsConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerAwsLogsConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AwsLogsConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CommandInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ContainerPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvironmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryCredentialsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerRepositoryCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RepositoryCredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainerSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecretInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Command
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContainerPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.ecsExpressGatewayService.EcsExpressGatewayServicePrimaryContainer\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainer cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.EcsExpressGatewayService.IEcsExpressGatewayServicePrimaryContainer).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
