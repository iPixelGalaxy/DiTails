﻿using Zenject;
using SiraUtil;
using IPA.Logging;
using DiTails.UI;
using DiTails.Managers;

namespace DiTails.Installers
{
    internal sealed class DiDMenuInstaller : Installer<Logger, DiDMenuInstaller>
    {
        private readonly Logger _logger;

        internal DiDMenuInstaller(Logger logger)
        {
            _logger = logger;
        }

        public override void InstallBindings()
        {
            Container.BindLoggerAsSiraLogger(_logger,
                #if DEBUG
                true
#else
                false
#endif
                );
            Container.BindInterfacesAndSelfTo<DetailViewHost>().AsSingle();
            Container.BindInterfacesAndSelfTo<DetailContextManager>().AsSingle();
        }
    }
}