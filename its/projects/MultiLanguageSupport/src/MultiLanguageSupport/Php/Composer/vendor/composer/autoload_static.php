<?php

// autoload_static.php @generated by Composer

namespace Composer\Autoload;

class ComposerStaticInit65acbe9cc067d65f7154ab67d3ab2a40
{
    public static $prefixLengthsPsr4 = array (
        'R' => 
        array (
            'Rivsen\\Demo\\' => 12,
        ),
    );

    public static $prefixDirsPsr4 = array (
        'Rivsen\\Demo\\' => 
        array (
            0 => __DIR__ . '/../..' . '/src',
        ),
    );

    public static $classMap = array (
        'Composer\\InstalledVersions' => __DIR__ . '/..' . '/composer/InstalledVersions.php',
    );

    public static function getInitializer(ClassLoader $loader)
    {
        return \Closure::bind(function () use ($loader) {
            $loader->prefixLengthsPsr4 = ComposerStaticInit65acbe9cc067d65f7154ab67d3ab2a40::$prefixLengthsPsr4;
            $loader->prefixDirsPsr4 = ComposerStaticInit65acbe9cc067d65f7154ab67d3ab2a40::$prefixDirsPsr4;
            $loader->classMap = ComposerStaticInit65acbe9cc067d65f7154ab67d3ab2a40::$classMap;

        }, null, ClassLoader::class);
    }
}
