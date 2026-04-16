using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecServiceOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecServiceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecServiceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecServiceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppSpecServiceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecServiceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAlert", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceAlert\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAlert(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecServiceAlert[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceAlert).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceAlert).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscaling\"}}]")]
        public virtual void PutAutoscaling(digitalocean.App.IAppSpecServiceAutoscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceAutoscaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBitbucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceBitbucket\"}}]")]
        public virtual void PutBitbucket(digitalocean.App.IAppSpecServiceBitbucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceBitbucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCors", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceCors\"}}]")]
        public virtual void PutCors(digitalocean.App.IAppSpecServiceCors @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceCors)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnv", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceEnv\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnv(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecServiceEnv[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceEnv).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceEnv).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceGit\"}}]")]
        public virtual void PutGit(digitalocean.App.IAppSpecServiceGit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceGit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceGithub\"}}]")]
        public virtual void PutGithub(digitalocean.App.IAppSpecServiceGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitlab", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceGitlab\"}}]")]
        public virtual void PutGitlab(digitalocean.App.IAppSpecServiceGitlab @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceGitlab)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceHealthCheck\"}}]")]
        public virtual void PutHealthCheck(digitalocean.App.IAppSpecServiceHealthCheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceHealthCheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putImage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceImage\"}}]")]
        public virtual void PutImage(digitalocean.App.IAppSpecServiceImage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceImage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestination\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogDestination(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecServiceLogDestination[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceLogDestination).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceLogDestination).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceRoutes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoutes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecServiceRoutes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceRoutes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecServiceRoutes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTermination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecServiceTermination\"}}]")]
        public virtual void PutTermination(digitalocean.App.IAppSpecServiceTermination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecServiceTermination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlert")]
        public virtual void ResetAlert()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscaling")]
        public virtual void ResetAutoscaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBitbucket")]
        public virtual void ResetBitbucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildCommand")]
        public virtual void ResetBuildCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCors")]
        public virtual void ResetCors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerfilePath")]
        public virtual void ResetDockerfilePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnv")]
        public virtual void ResetEnv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentSlug")]
        public virtual void ResetEnvironmentSlug()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGit")]
        public virtual void ResetGit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithub")]
        public virtual void ResetGithub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitlab")]
        public virtual void ResetGitlab()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpPort")]
        public virtual void ResetHttpPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImage")]
        public virtual void ResetImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceCount")]
        public virtual void ResetInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceSizeSlug")]
        public virtual void ResetInstanceSizeSlug()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternalPorts")]
        public virtual void ResetInternalPorts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogDestination")]
        public virtual void ResetLogDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutes")]
        public virtual void ResetRoutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunCommand")]
        public virtual void ResetRunCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDir")]
        public virtual void ResetSourceDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTermination")]
        public virtual void ResetTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "alert", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAlertList\"}")]
        public virtual digitalocean.App.AppSpecServiceAlertList Alert
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceAlertList>()!;
        }

        [JsiiProperty(name: "autoscaling", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscalingOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceAutoscalingOutputReference Autoscaling
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceAutoscalingOutputReference>()!;
        }

        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceBitbucketOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceBitbucketOutputReference Bitbucket
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceBitbucketOutputReference>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceCorsOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceCorsOutputReference Cors
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceCorsOutputReference>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceEnvList\"}")]
        public virtual digitalocean.App.AppSpecServiceEnvList Env
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceEnvList>()!;
        }

        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGitOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceGitOutputReference Git
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceGitOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGithubOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceGithubOutputReference Github
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceGithubOutputReference>()!;
        }

        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGitlabOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceGitlabOutputReference Gitlab
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceGitlabOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceHealthCheckOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceHealthCheckOutputReference HealthCheck
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceHealthCheckOutputReference>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceImageOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceImageOutputReference Image
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceImageOutputReference>()!;
        }

        [JsiiProperty(name: "logDestination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestinationList\"}")]
        public virtual digitalocean.App.AppSpecServiceLogDestinationList LogDestination
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceLogDestinationList>()!;
        }

        [JsiiProperty(name: "routes", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceRoutesList\"}")]
        public virtual digitalocean.App.AppSpecServiceRoutesList Routes
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceRoutesList>()!;
        }

        [JsiiProperty(name: "termination", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceTerminationOutputReference\"}")]
        public virtual digitalocean.App.AppSpecServiceTerminationOutputReference Termination
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecServiceTerminationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "alertInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceAlert\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AlertInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceAutoscaling\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceAutoscaling? AutoscalingInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceAutoscaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitbucketInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceBitbucket\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceBitbucket? BitbucketInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceBitbucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildCommandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildCommandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceCors\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceCors? CorsInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceCors?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerfilePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DockerfilePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "envInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentSlugInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentSlugInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGithub\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceGithub? GithubInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGit\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceGit? GitInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceGit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitlabInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceGitlab\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceGitlab? GitlabInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceGitlab?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceHealthCheck\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceHealthCheck? HealthCheckInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceHealthCheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HttpPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceImage\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceImage? ImageInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceImage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceSizeSlugInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceSizeSlugInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalPortsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? InternalPortsInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDestinationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceLogDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogDestinationInput
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
        [JsiiProperty(name: "routesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecServiceRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RoutesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runCommandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RunCommandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDirInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceDirInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminationInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecServiceTermination\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecServiceTermination? TerminationInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecServiceTermination?>();
        }

        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildCommand
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerfilePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentSlug
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceSizeSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceSizeSlug
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "internalPorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] InternalPorts
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunCommand
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDir
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecService\"}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecService cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecService).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
